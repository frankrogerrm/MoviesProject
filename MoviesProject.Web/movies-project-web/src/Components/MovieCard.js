import { Component } from "react";
import { Card, Col, ListGroup } from "react-bootstrap";

export class MovieCard extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Movie: props.movie,
    };
  }

  render() {
    return (
      <Col className="col-padding">
        <Card style={{ padding: "32px", height: "100%" }}>
          <Card.Img
            variant="top"
            src={
              this.state.Movie.imageUrl
                ? this.state.Movie.imageUrl
                : "https://thumbs.dreamstime.com/z/tarnow-poland-april-imdb-logo-smartphone-display-screen-mdb-online-database-information-related-to-films-216919169.jpg"
            }
            onError={({ currentTarget }) => {
              currentTarget.onerror = null; // prevents looping
              currentTarget.src =
                "https://thumbs.dreamstime.com/z/tarnow-poland-april-imdb-logo-smartphone-display-screen-mdb-online-database-information-related-to-films-216919169.jpg";
            }}
          />
          <Card.Body>
            <Card.Title style={{ textAlign: "center", padding: "24px" }}>
              {this.state.Movie.title}
            </Card.Title>
            <div>
              <ListGroup className="list-group-flush">
                <ListGroup.Item>Year : {this.state.Movie.year}</ListGroup.Item>
                <ListGroup.Item>
                  Directors : {this.state.Movie.directors}
                </ListGroup.Item>
                <ListGroup.Item>
                  Actors : {this.state.Movie.actors}
                </ListGroup.Item>
                <ListGroup.Item>
                  Genres : {this.state.Movie.genres}
                </ListGroup.Item>
                <ListGroup.Item>Plot : {this.state.Movie.plot}</ListGroup.Item>
              </ListGroup>
            </div>
          </Card.Body>
        </Card>
      </Col>
    );
  }
}
