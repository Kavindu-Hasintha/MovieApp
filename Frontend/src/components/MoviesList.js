import React from "react";

import Movie from "./Movie";
import classes from "./MoviesList.module.css";

const MovieList = (props) => {
  return (
    <ul className={classes["movies-list"]}>
      {props.movies.map((movie) => (
        <Movie
          key={movie.episode_Id}
          title={movie.title}
          releaseDate={movie.release}
          openingText={movie.openingText}
        />
      ))}
    </ul>
  );
};

export default MovieList;
