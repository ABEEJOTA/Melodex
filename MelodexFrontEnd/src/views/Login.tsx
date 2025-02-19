import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../contexts/AuthContext';

export default function Login() {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const { login } = useAuth();
  const navigate = useNavigate();

  const handleLogin = () => {
    // Aquí, deberías verificar las credenciales del usuario
    if (username === 'user' && password === 'password') {
      login(); // Marca al usuario como autenticado
      navigate('/collection'); // Redirige a la página de colecciones
    } else {
      alert('Credenciales incorrectas');
    }
  };

  return (
    <>
        <div>
        <h2>Login</h2>
        <input 
            type="text" 
            value={username} 
            onChange={(e) => setUsername(e.target.value)} 
            placeholder="Username"
        /><br/>
        <input 
            type="password" 
            value={password} 
            onChange={(e) => setPassword(e.target.value)} 
            placeholder="Password"
        /><br/>
        <button onClick={handleLogin}>Log In</button>
        </div>
        <div>
            <a onClick={()=>navigate('/register')}>Don't have an account? Create one</a>
        </div>
    </>
    
  );
}
