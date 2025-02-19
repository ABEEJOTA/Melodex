import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';

export default function Register() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const navigate = useNavigate();

  const handleSubmit = async (event: React.FormEvent) => {
    event.preventDefault();

    if (password !== confirmPassword) {
      alert('Las contraseñas no coinciden');
      return;
    }

    // Aquí deberías registrar al usuario en tu sistema
    // Si el registro es exitoso, redirigir a login
    alert('Registro exitoso');
    navigate('/login');
  };

  return (
    <>
        <div>
        <h2>Registrarse</h2>
        <form onSubmit={handleSubmit}>
            <div>
            <label>Email</label>
            <input
                type="email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
                required
            />
            </div>
            <div>
            <label>Contraseña</label>
            <input
                type="password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
            />
            </div>
            <div>
            <label>Confirmar Contraseña</label>
            <input
                type="password"
                value={confirmPassword}
                onChange={(e) => setConfirmPassword(e.target.value)}
                required
            />
            </div>
            <div>
            <button type="submit">Registrarse</button>
            </div>
        </form>
        </div>
        <div>
            <a onClick={()=>navigate('/login')}>Already have an account? Login</a>
        </div>
    </>
  );
}
