import React, { useRef } from "react";

import classes from "./AddMovie.module.css";

function AddMovie(props) {
  const titleRef = useRef("");
  const openingTextRef = useRef("");
  const directorRef = useRef("");
  const producerRef = useRef("");
  const releaseDateRef = useRef("");

  function submitHandler(event) {
    event.preventDefault();

    // could add validation here...

    const movie = {
      title: titleRef.current.value,
      opening_Crawl: openingTextRef.current.value,
      director: directorRef.current.value,
      producer: producerRef.current.value,
      release_Date: releaseDateRef.current.value,
    };

    props.onAddMovie(movie);

    titleRef.current.value = "";
    openingTextRef.current.value = "";
    directorRef.current.value = "";
    producerRef.current.value = "";
    releaseDateRef.current.value = "";
  }

  return (
    <form onSubmit={submitHandler}>
      <div className={classes.control}>
        <label htmlFor="title">Title</label>
        <input type="text" id="title" ref={titleRef} />
      </div>
      <div className={classes.control}>
        <label htmlFor="opening-text">Opening Text</label>
        <textarea rows="5" id="opening-text" ref={openingTextRef}></textarea>
      </div>
      <div className={classes.control}>
        <label htmlFor="director">Director</label>
        <input type="text" id="director" ref={directorRef} />
      </div>
      <div className={classes.control}>
        <label htmlFor="producer">Producer</label>
        <input type="text" id="producer" ref={producerRef} />
      </div>
      <div className={classes.control}>
        <label htmlFor="date">Release Date</label>
        <input type="text" id="date" ref={releaseDateRef} />
      </div>
      <button>Add Movie</button>
    </form>
  );
}

export default AddMovie;
