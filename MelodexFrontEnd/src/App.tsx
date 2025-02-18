import { BrowserRouter as Router } from 'react-router-dom';
import AppRoutes from './routes/AppRoutes';
import BurgerMenu from './components/BurgerMenu';

export default function App() {
  return (
    <Router>
      <AppRoutes />
      <BurgerMenu
        elements={[
          { text: 'Collection', path: '/collection' },
          { text: 'Playlists', path: '/playlists' },
        ]}
      />
    </Router>
  );
}
