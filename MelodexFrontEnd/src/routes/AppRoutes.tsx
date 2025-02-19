import { Routes, Route, Navigate } from 'react-router-dom';
import Collection from '../views/Collection';
import Login from '../views/Login';
import Register from '../views/Register';
import ProtectedRoute from '../components/ProtectedRoute';
import PlayLists from '../views/PlayLists';

export default function AppRoutes() {
  return (
    <Routes>
      <Route path="/" element={<Navigate to="/collection" replace />} />
      <Route path="/login" element={<Login />} />
      <Route path="/register" element={<Register />} />

      {/* Rutas protegidas */}
      <Route element={<ProtectedRoute />}>
        <Route path="/collection" element={<Collection />} />
        <Route path="/playlists" element={<PlayLists />} />
      </Route>
    </Routes>
  );
}
