import { createBrowserRouter } from "react-router";
import App from "../layout/App";
import HomePage from "../features/home/HomePage";
import ClimbsDashboard from "../features/climbs/details/ClimbsDashboard";
import ClimbForm from "../features/climbs/forms/ClimbForm";
import ClimbDetails from "../features/climbs/details/ClimbDetails";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            { path: '', element: <HomePage /> },
            { path: 'climbs', element: <ClimbsDashboard /> },
            { path: 'climbs/:id', element: <ClimbDetails />},
            { path: 'createClimb', element: <ClimbForm key='create'/> },
            { path: 'editClimb/:id', element: <ClimbForm /> },
        ]
    }
])