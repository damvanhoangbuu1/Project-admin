import _ from 'lodash';
import { fetchEmployees, updateEmployee, fetchEmployee, addUserSkill, getUserSkills, removeUserSkills, getTimeLineEvents, addTimeLineEvent, removeTimeLineEvents, createNewSkill, createEmployee } from '../utils/api';
import { PROFILE_MODAL_TYPE } from '../utils/constants';

export default {
  namespace: 'people',
  state: {
    dataSource: [],
    page: 1,
    pageSize: 20,
    total: 100,
    selectedEmployee: undefined,
    modalVisible: false,
    selectedPosition: undefined,
    selectedSkills: [],
    profileModalType: PROFILE_MODAL_TYPE.EDIT,
    employees: {},
    searchFilter: ''
  },
  subscriptions: {
    setup({ dispatch, history }) {
      history.listen(({ pathname }) => {
        if (pathname.toLowerCase() === '/people') {
          dispatch({
            type: 'fetch'
          });
        }
      });
    },
  },
  effects: {
    *fetch({ payload }, { call, put, select }) {
      const { page, pageSize, selectedPosition, selectedSkills, searchFilter } = yield select(state => state.people);
      const positionId = selectedPosition ? selectedPosition.id : '';
      const skillIds = selectedSkills.map(skill => skill.id).join(',');
      const response = yield call(fetchEmployees, page, pageSize, positionId, skillIds, searchFilter);
      yield put({ type: 'fetchSuccess', payload: response });
    },
    *changePagination({ payload }, { call, put, select }) {
      yield put({ type: 'savePagination', payload });
      yield put({ type: 'fetch' });
    },
    *changePositionFilter({ payload }, { call, put, select }) {
      yield put({ type: 'savePositionTag', payload });
      yield put({ type: 'fetch' });
    },
    *changeSearchFilter({ payload }, { call, put, select }) {
      yield put({ type: 'saveSearchFilter', payload });
      yield put({ type: 'fetch' });
    },
    *changeSkillsFilter({ payload }, { call, put, select }) {
      yield put({ type: 'saveSkillTags', payload });
      yield put({ type: 'fetch' });
    },
    *createEmployee({ payload }, { call, put, select }) {
      yield call(createEmployee, payload);
      yield put({ type: 'closeModal' });
      yield put({ type: 'fetch' });
      window.location.reload();
    },
    *updateEmployeeProfile({ payload }, { call, put, select }) {
      yield call(updateEmployee, payload);
      yield put({ type: 'closeModal' });
      const { profile } = yield select(state => state.passport);
      if (payload.id === profile.id) {
        yield put({ type: 'passport/updateProfile', payload: profile.id });
      }
      window.location.reload();
    },
    *showProfile({ payload: id }, { call, put, select }) {
      const { data } = yield call(fetchEmployee, id);
      yield put({ type: 'selectEmployee', payload: data });
      const selectedEmployee = yield select(state => state.people.selectedEmployee);
      yield put({ type: 'getTimeLineEvents', payload: selectedEmployee.id });
    },
    *editProfile({ payload }, { call, put, select }) {
      yield put({ type: 'positions/fetchAll' });
      yield put({ type: 'skills/fetchAll' });
      yield put({ type: 'changeViewType', payload: PROFILE_MODAL_TYPE.EDIT });
    },
    *addUserSkill({ payload }, { call, put, select }) {
      const { newSkillName, skillId, userId } = payload;
      if (newSkillName) {
        const { data: { id } } = yield call(createNewSkill, newSkillName);
        yield call(addUserSkill, { userId, skillId: id });
      } else {
        yield call(addUserSkill, { userId, skillId });
      }
      yield put({ type: 'getUserSkills' });
    },
    *getUserSkills({ payload }, { call, put, select }) {
      const { id } = yield select(state => state.people.selectedEmployee);
      const { data } = yield call(getUserSkills, id);
      yield put({ type: 'getUserSkillsSuccess', payload: data });
    },
    *removeUserSkills({ payload: id }, { call, put, select }) {
      yield call(removeUserSkills, id);
      yield put({ type: 'getUserSkills' });
    },
    *addTimeLineEvent({ payload }, { call, put, select }) {
      yield call(addTimeLineEvent, payload);
      const { id } = yield select(state => state.people.selectedEmployee);
      yield put({ type: 'getTimeLineEvents', payload: id });
    },
    *getTimeLineEvents({ payload: userId }, { call, put, select }) {
      const { data } = yield call(getTimeLineEvents, userId);
      yield put({ type: 'getTimeLineEventsSuccess', payload: data });
    },
    *removeTimeLineEvents({ payload: id }, { call, put, select }) {
      yield call(removeTimeLineEvents, id);
      const { id: userId } = yield select(state => state.people.selectedEmployee);
      yield put({ type: 'getTimeLineEvents', payload: userId });
    },
  },
  reducers: {
    fetchSuccess(state, { payload }) {
      return {
        ...state,
        dataSource: payload.data,
        total: payload.total,
        employees: _.keyBy(payload.data, 'id')
      };
    },
    savePagination(state, { payload }) {
      return {
        ...state,
        ...payload,
      };
    },
    closeModal(state, { payload }) {
      return {
        ...state,
        modalVisible: false,
        selectedEmployee: null,
      };
    },
    selectEmployee(state, { payload: selectedEmployee }) {
      return {
        ...state,
        modalVisible: true,
        selectedEmployee,
        profileModalType: PROFILE_MODAL_TYPE.VIEW
      };
    },
    savePositionTag(state, { payload }) {
      return {
        ...state,
        selectedPosition: payload,
      };
    },
    saveSearchFilter(state, { payload }) {
      return {
        ...state,
        searchFilter: payload,
      };
    },
    saveSkillTags(state, { payload }) {
      const { tag, checked } = payload;
      return {
        ...state,
        selectedSkills: checked
          ? [...state.selectedSkills, tag]
          : state.selectedSkills.filter(t => t !== tag),
      };
    },
    changeViewType(state, { payload: profileModalType }) {
      return {
        ...state,
        profileModalType
      };
    },
    openEmployeeForm(state, { payload }) {
      return {
        ...state,
        profileModalType: PROFILE_MODAL_TYPE.CREATE,
        modalVisible: true
      };
    },
    getUserSkillsSuccess(state, { payload: skills }) {
      return {
        ...state,
        selectedEmployee: {
          ...state.selectedEmployee,
          skills
        }
      };
    },
    getTimeLineEventsSuccess(state, { payload: timeLineEvents }) {
      return {
        ...state,
        selectedEmployee: {
          ...state.selectedEmployee,
          timeLineEvents
        }
      };
    },
  },
};
