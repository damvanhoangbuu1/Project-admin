import logo from '../assets/logo4.png';
import { APP_CONSTANTS } from './constants';

export default { logo };

export const parseImage = (relativePath) => `${APP_CONSTANTS.API_UPLOAD_URL}files/${relativePath}`;
