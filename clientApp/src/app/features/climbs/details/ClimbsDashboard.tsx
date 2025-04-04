import { Card, Grid2} from "@mui/material";
import ClimbsAccordionList from "./ClimbsAccordionList";

export default function ClimbsDashboard() {

  
  return (
    <Grid2 container spacing={3}>
      <Grid2 size={9}>
        <ClimbsAccordionList />
      </Grid2>
      <Grid2 size={3}>
        Climb filters go here and 
        <Card>
          Most popular
        </Card>
        <Card>
          Hardest
        </Card>
        <Card>
          Highest rated
        </Card>
      </Grid2>

    </Grid2>
  );
}
