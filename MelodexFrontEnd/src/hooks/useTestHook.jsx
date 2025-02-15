import axios from "axios";

export function useTestHook(setWeather){
    const GetWeather = () => {
        axios.
        get("https://localhost:7033/WeatherForecast").
        then((response) => setWeather(response.data));
    }

    return{
        GetWeather
    } 
}