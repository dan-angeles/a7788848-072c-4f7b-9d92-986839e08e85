import { GetData } from "./components/GetData";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/getdata',
    element: <GetData />
  }
];

export default AppRoutes;
