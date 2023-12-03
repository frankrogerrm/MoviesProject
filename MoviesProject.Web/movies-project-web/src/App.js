import "./App.css";
import { SearchMovies } from "./ApiCalls/ApiCalls";
import { SearchInput } from "./Components/SearchInput";
import { MovieCard } from "./Components/MovieCard";
import { Col, Container, Row } from "react-bootstrap";
import { useState } from "react";

function App() {
  const [movies, setMovies] = useState([]);

  const searchMovie = (par) => {
    if (par.trim().length > 2) {
      SearchMovies(par.trim()).then((res) => setMovies(res.data));
    } else if (par.trim().length === 0) {
      setMovies([]);
    }
  };

  return (
    <Container>
      <br></br>
      <Row xs={1} md={3}>
        <Col></Col>
        <Col>
          <SearchInput searchMovie={searchMovie}></SearchInput>
        </Col>
        <Col></Col>
      </Row>
      <br></br>
      <Row xs={1} md={3}>
        {movies.length > 0 &&
          movies.map((e, i) => <MovieCard key={e.id} movie={e}></MovieCard>)}
        {movies.length === 0 && (
          <p className="no-results-div" style={{ width: "100%" }}>
            No Results
          </p>
        )}
      </Row>
    </Container>
  );
}
export default App;
