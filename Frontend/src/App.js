import React, { useState } from "react";

import MoviesList from "./components/MoviesList";
import "./App.css";

function App() {
  const [movies, setMovies] = useState([]);
  function fetchMovieHandler() {
    // Default method of fetch is GET
    // Sending a HTTP request is an asynchronous task
    // It doesn't finish immediately
    // So we use then, it means when we get a response
    // catch to handle any errors
    // response in then - it is an object with the bunch of data about the response
    // response.json() - automatically translate JSON response body to a real JS object
    // data - earlier data transformation is done

    fetch("")
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        const transformedMovies = data.results.map((movieData) => {
          return {
            id: movieData.episode_id,
            title: movieData.title,
            openingText: movieData.opening_crawl,
            releaseData: movieData.release_date,
          };
        });
        setMovies(transformedMovies);
      });
  }

  return (
    <React.Fragment>
      <section>
        <button onClick={fetchMovieHandler}>Fetch Movies</button>
      </section>
      <section>
        <MoviesList movies={movies} />
      </section>
    </React.Fragment>
  );
}

export default App;
