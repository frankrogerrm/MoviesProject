import { Component } from "react";
import Form from "react-bootstrap/Form";

export class SearchInput extends Component {
  constructor(props) {
    super(props);
    this.state = { searchText: "" };
    this.handleChange = this.handleChange.bind(this);
  }

  handleChange(e) {
    this.setState({
      searchText: e.target.value,
    });
    this.props.searchMovie(e.target.value);
  }

  render() {
    return (
      <div>
        <Form.Control
          value={this.state.searchText}
          onChange={this.handleChange}
          placeholder="Insert Name, Year or Keywords of the Movie"
        ></Form.Control>
      </div>
    );
  }
}
