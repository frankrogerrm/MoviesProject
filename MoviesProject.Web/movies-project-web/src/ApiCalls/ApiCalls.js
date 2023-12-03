import axios from "axios";

const api = axios.create({
  baseURL: process.env.REACT_APP_BASE_URL,
});

export function GetMovies() {
  return api
    .get("/api/movies/get")
    .then((res) => console.log(res.data))
    .catch((error) => console.log(error));
}

export function GetMoviesById(id) {
  return api.get(`/api/movies/get/${id}`).catch((error) => console.log(error));
}

export function GetMoviesByTitle(title) {
  return api
    .get(`/api/movies/search/title/${title}`)
    .catch((error) => console.log(error));
}

export function GetMoviesByDescription(description) {
  return api
    .get(`/api/movies/search/description/${description}`)
    .catch((error) => console.log(error));
}

export function SearchMovies(query) {
  return api
    .get(`/api/movies/search/${query}`)
    .catch((error) => console.log(error));
}
