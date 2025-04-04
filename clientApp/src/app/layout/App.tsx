import './App.css'
import { Box, Container, CssBaseline } from '@mui/material';
import NavBar from './NavBar';
import { Outlet } from 'react-router';

function App() {

  return (
    <Box sx={{backgroundColor:'#eeeeee', minHeight: '100vh'}}>
      <CssBaseline/> {/* Sets padding and margins to 0 */}
      <NavBar />
      <Container maxWidth='xl' sx={{mt:3}}>
        <Outlet />
      </Container>
    </Box>
  )
}

export default App
