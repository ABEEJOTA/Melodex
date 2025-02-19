import { Navigate, Outlet } from 'react-router-dom';
import { useAuth } from '../contexts/AuthContext';

export default function ProtectedRoute() {
  const { isAuthenticated } = useAuth();

  if (!isAuthenticated) {
    // Si no está autenticado, redirige al login
    return <Navigate to="/login" />;
  }

  // Si está autenticado, muestra la ruta hija
  return <Outlet />;
}
