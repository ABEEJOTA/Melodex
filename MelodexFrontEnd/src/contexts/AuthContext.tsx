import { createContext, useContext, useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";

interface AuthContextType {
  token: string | null;
  login: (email: string, password: string) => Promise<boolean>;
  register: (email: string, username: string, password: string) => Promise<boolean>;
  logout: () => void;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);

export function AuthProvider({ children }: { children: React.ReactNode }) {
  const [token, setToken] = useState<string | null>(localStorage.getItem("jwt"));
  const navigate = useNavigate();

  useEffect(() => {
    const storedToken = localStorage.getItem("jwt");
    if (storedToken) {
      setToken(storedToken);
    } else {
      setToken(null);
    }
  }, []);

  const login = async (email: string, password: string) => {
    try {
      const response = await fetch("https://localhost:7033/api/auth/login", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ email, password }),
      });

      if (!response.ok) return false;

      const data = await response.json();
      console.log("Respuesta del login:", data);

      localStorage.setItem("jwt", data.token);
      setToken(data.token);
      
      navigate("/collection"); // Redirige al usuario tras el login exitoso
      return true;
    } catch (error) {
      console.error("Error logging in", error);
      return false;
    }
  };

  const register = async (email: string, username: string, password: string) => {
    try {
      const response = await fetch("https://localhost:7033/api/auth/register", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ email, username, password }),
      });

      return response.ok;
    } catch (error) {
      console.error("Error registering", error);
      return false;
    }
  };

  const logout = () => {
    localStorage.removeItem("jwt");
    setToken(null);
    navigate("/login");
  };

  return (
    <AuthContext.Provider value={{ token, login, register, logout }}>
      {children}
    </AuthContext.Provider>
  );
}

export function useAuth() {
  const context = useContext(AuthContext);
  if (!context) throw new Error("useAuth must be used within an AuthProvider");
  return context;
}
