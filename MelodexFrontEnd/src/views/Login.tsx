import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { useAuth } from "../contexts/AuthContext";

export default function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const { login } = useAuth();
  const navigate = useNavigate();

  const handleLogin = async () => {
    const success = await login(email, password);
    if (success) {
      console.log("HOLA")
      setTimeout(() => {
        console.log("Intentando navegar...");
        navigate("/collection");
      }, 100);
    } else {
      alert("Credenciales incorrectas");
    }
  };

  return (
    <div>
      <h2>Login</h2>
      <input
        type="text"
        value={email}
        onChange={(e) => setEmail(e.target.value)}
        placeholder="Email"
      /><br />
      <input
        type="password"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
        placeholder="Password"
      /><br />
      <button onClick={handleLogin}>Log In</button>
      <div>
        <a onClick={() => navigate("/register")}>Don't have an account? Create one</a>
      </div>
    </div>
  );
}
