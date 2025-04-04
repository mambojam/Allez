import { Box, Button, FormControl, InputLabel, MenuItem, Paper, Select, TextField, Typography } from '@mui/material'
import { FormEvent, useState } from 'react';
import { useClimbs } from '../../../lib/hooks/useClimbs';
import { useNavigate, useParams } from 'react-router';

const sportGrades : string[] = ["3", "4", "5", "6a", "6a+", "6b", "6b+", "6c", "6c+", "7a", "7a+", "7b", "7b+", "7c", "7c+", "8a", "8a+", "8b", "8b+", "8c", "8c+", "9a", "9a+", "9b", "9b+", "9c"]
const boulderGrades : string[] = ["VB", "V0", "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "V10", "V11", "V12", "V13", "V14", "V15", "V16", "V17"]
const tradGrades : string[] = ["Mod", "Diff", "VDiff", "HVD", "S", "HS", "VS", "HVS", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10", "E11"]

export default function ClimbForm() {
  const {id} = useParams();
  const {updateClimbs, createClimb, climb, isLoadingClimb} = useClimbs(id);
  const navigate = useNavigate();

  const [discipline, setDiscipline] = useState(climb?.disciplineType ?? "");
  const handleSetDiscipline = (target : string) => {
    console.log(target);
    setDiscipline(target);
  }



  const handleSubmit = async (event : FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    const formData = new FormData(event.currentTarget);
    const data : {[key: string]: FormDataEntryValue} = {}
    formData.forEach((value, key) => {
      data[key] = value;
    })

    if (climb) {
      data.id = climb.id;
      await updateClimbs.mutateAsync(data as unknown as Climb);
      navigate(`/climbs/${climb.id}`)
    } else {
      createClimb.mutate(data as unknown as Climb, {
        onSuccess: (id) => {
          console.log(id);
          navigate(`/climbs/${id}`)
        }
      });
    }
  }

  
  if (isLoadingClimb) return <Typography>Loading climb...</Typography>

  return (
    <Paper sx={{borderRadius:3, padding:3}} id="climb-form">
      <Typography variant='h5' gutterBottom color='primary'>
        Create Climb
      </Typography>
      <Box component='form' onSubmit={handleSubmit} display='flex' flexDirection='column' gap={3}>
        
        <TextField label='Name' name='name' defaultValue={climb?.name}/>
        

        <FormControl>
        <InputLabel id="discipline-select-label">Discipline</InputLabel>
        <Select
          labelId="discipline-select-label"
          id="discipline-select-standard"
          label="Discipline"
          defaultValue={climb?.disciplineType}
          onChange={(e) => handleSetDiscipline(e.target.value)}
          name='disciplineType'
        >
          <MenuItem value="">
            <em>None</em>
          </MenuItem>
          <MenuItem value="Boulder">Boulder</MenuItem>
            <MenuItem value="Sport">Sport</MenuItem>
            <MenuItem value="Trad">Trad</MenuItem>
        </Select>

      </FormControl>
      <FormControl>
      <InputLabel id="grade-select-label">Grade</InputLabel>

      <Select
          labelId="grade-select-label"
          id="grade-select-standard"
          label="Grade"
          defaultValue={climb?.grade}
          name='grade'

          >
            {discipline == "Boulder" && 
            boulderGrades.map((grade) => (
              <MenuItem value={grade}>
              {grade}
            </MenuItem>
            ))}
            {discipline === "Sport" && 
             sportGrades.map((grade) => (
              <MenuItem value={grade}>
              {grade}
            </MenuItem>
            ))}
            {discipline == "Trad" &&
            tradGrades.map((grade) => (
              <MenuItem value={grade}>
              {grade}
            </MenuItem>
            )) }
          </Select>
        </FormControl>          
        
      
          <TextField label='Description' name='description' defaultValue={climb?.description} multiline rows={3}/>
          <TextField label='Location' name='location' defaultValue={climb?.location}/>

        <Box display='flex' justifyContent='end' gap={3}>
          <Button 
          color='inherit'
          onClick={() => navigate(climb ? `/climbs/${climb.id}` : '/climbs')}
          >
            Cancel
          </Button>
          <Button 
          type='submit' 
          color='success' 
          variant='contained'
          disabled={updateClimbs.isPending || createClimb.isPending}
          >
            Submit</Button>
        </Box>
          
      </Box>

    </Paper>
  )
}
