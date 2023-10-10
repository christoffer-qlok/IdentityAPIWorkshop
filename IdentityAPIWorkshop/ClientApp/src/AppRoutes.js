import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import Game from "./components/Game";
import Highscore from "./components/Highscore";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/game',
    requireAuth: true,
    element: <Game />
  },
  {
    path: '/highscore',
    element: <Highscore />
  },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
