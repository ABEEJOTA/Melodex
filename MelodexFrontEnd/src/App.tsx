import { BrowserRouter as Router } from 'react-router-dom';
import AppRoutes from './routes/AppRoutes';
import BurgerMenu from './components/BurgerMenu';
import { menuOptions } from './constants/MenuOptions';
import { AuthProvider } from './contexts/AuthContext';

export default function App() {
  return (
    <Router>
      <AuthProvider>
        <AppRoutes />
        <BurgerMenu menuOptions={menuOptions}/>
      </AuthProvider>
    </Router>
  );
}
