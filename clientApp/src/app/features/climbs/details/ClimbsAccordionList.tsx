import { ExpandMore, GestureTwoTone, StyleTwoTone } from "@mui/icons-material";
import {
  Accordion,
  AccordionSummary,
  Box,
  Typography,
  AccordionDetails,
  AccordionActions,
  Button,
} from "@mui/material";
import { useState } from "react";
import { useClimbs } from "../../../lib/hooks/useClimbs";
import { useNavigate } from "react-router";


export default function ClimbsAccordionList() {

  const {climbs, isPending, deleteClimb} = useClimbs();
  const navigate = useNavigate();
  const [expandedId, setExpandedId] = useState("");


  if (!climbs || isPending) return <Typography>Loading...</Typography>


  const handleExpandedChange = (id: string) => {
    if (id === expandedId) {
      setExpandedId("");
    } else {
      setExpandedId(id);
    }
  };
  return (
    <Box key={"climbs-accordion-list"}>
      <Accordion
        expanded={false}
        sx={{ backgroundColor: "black", color: "white" }}
      >
        <AccordionSummary
          aria-controls="panel1-content"
          id={"header"}
          sx={{
            width: "100%",
          }}
        >
          <Box
            sx={{
              display: "flex",
              flexGrow: 1,
              width: "100%",
              bgColor: "white",
            }}
          >
            {/* NAME */}
            <Typography variant="h6" sx={{ width: "200px", flexShrink: 0 }}>
              Name
            </Typography>

            {/* OTHER DETAILS */}
            <Box
              sx={{
                width: "100px",
                flexGrow: 1,
                display: "flex",
                justifyContent: "space-evenly",
              }}
            >
              <Typography variant="h6">Discipline</Typography>
              <Typography variant="h6">Grade</Typography>
              <Typography variant="h6">Rating</Typography>
            </Box>
          </Box>
        </AccordionSummary>
      </Accordion>
      {climbs.map((climb) => (
        <Accordion
          expanded={expandedId === climb.id}
          onChange={() => handleExpandedChange(climb.id)}
          sx={{ borderRadius: "3px" }}
          key={climb.id}
        >
          <AccordionSummary
            expandIcon={<ExpandMore />}
            aria-controls="panel1-content"
            id={climb.id}
            sx={{
              width: "100%",
            }}
          >
            <Box
              sx={{
                display: "flex",
                flexGrow: 1,
                width: "100%",
                bgColor: "white",
              }}
            >
              {/* NAME */}
              <Typography
                variant="subtitle1"
                sx={{ width: "200px", flexShrink: 0 }}
              >
                {climb.name ? climb.name : "{No name}"}
              </Typography>

              {/* OTHER DETAILS */}
              <Box
                sx={{
                  width: "100px",
                  flexGrow: 1,
                  display: "flex",
                  justifyContent: "space-evenly",
                }}
              >
                {climb.disciplineType === "Sport" ? (
                  <GestureTwoTone />
                ) : (
                  <StyleTwoTone />
                )}
                <Typography variant="subtitle1">{climb.grade}</Typography>
                <Typography variant="subtitle1">
                  {climb.rating ? climb.rating : "N/A"}
                </Typography>
              </Box>
            </Box>
          </AccordionSummary>
          <AccordionDetails>{climb.description}</AccordionDetails>
          <AccordionActions>
            <Button
              onClick={() => navigate(`/climbs/${climb.id}`)}
              color="inherit"
              variant="contained"
            >
              Details
            </Button>
            <Button
              onClick={() => deleteClimb.mutate(climb.id)}
              color="error"
              variant="contained"
              disabled={deleteClimb.isPending}
            >
              Delete
            </Button>
          </AccordionActions>
        </Accordion>
      ))}
    </Box>
  );
}
