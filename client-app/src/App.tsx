import { useEffect, useState } from "react";
import axios from "axios";
import "./App.css";
import { Header } from "semantic-ui-react";
import List from "semantic-ui-react/dist/commonjs/elements/List";
import Button from "semantic-ui-react/dist/commonjs/elements/Button";

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios
      .get("http://localhost:5000/api/activities")
      .then((response) => setActivities(response.data));
  }, [setActivities]);

  return (
    <div>
      <Header as="h2" icon="users" content="Reactivities" />
      <List>
        {activities.map((activity: any) => (
          <List.Item key={activity.id}>{activity.title}</List.Item>
        ))}
      </List>
      <Button content="button" />
    </div>
  );
}

export default App;
