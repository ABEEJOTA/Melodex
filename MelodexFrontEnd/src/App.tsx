import { BrowserRouter as Router } from 'react-router-dom';
import AppRoutes from './routes/AppRoutes';
import BurgerMenu from './components/BurgerMenu';
import { menuOptions } from './constants/MenuOptions';

export default function App() {
  return (
    <Router>
      <AppRoutes />
      <BurgerMenu menuOptions={menuOptions}/>
    </Router>
  );
}
