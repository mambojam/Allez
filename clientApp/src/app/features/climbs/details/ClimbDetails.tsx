import { Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material"
import { useClimbs } from "../../../lib/hooks/useClimbs";
import { useNavigate, useParams } from "react-router";

export default function ClimbDetails() {
  const navigate = useNavigate();
  const {id} = useParams();
  const {climb, isLoadingClimb} = useClimbs(id);

  if (isLoadingClimb) return <Typography>Loading...</Typography>

  if (!climb) return <Typography>Climb not found...</Typography>

  
  return (
    <Card sx={{borderRadius: 3}}>
      <CardMedia 
        component='img'
        src={`/images/locationImages/${climb.location}.jpg`}
      />
      <CardContent>
        <Typography variant="h5">{climb.name}</Typography>
        <Typography variant="h6">{climb.grade}</Typography>
        <Typography variant="subtitle1" fontWeight='light'>{climb.rating}</Typography>
        <Typography variant="body1">{climb.description}</Typography>
      </CardContent>
      <CardActions>
        <Button color="primary" onClick={() => navigate(`/editClimb/${climb.id}`)}>Edit</Button>
        <Button color="inherit" onClick={() => navigate('/climbs')}>Cancel</Button>
      </CardActions>
    </Card>
  )
}
