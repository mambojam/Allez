import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import agent from "../api/agent";

export const useClimbs = (id?: string) => {
    const queryClient = useQueryClient();
    
    const {data: climbs, isPending} = useQuery({
        queryKey: ['climbs'],
        queryFn: async () => {
          const response = await agent.get<Climb[]>('/climbs');
          return response.data;
        }
    });

    const {data: climb, isLoading: isLoadingClimb} = useQuery({
        queryKey: ['climbs', id],
        queryFn: async () => {
          const response = await agent.get<Climb>(`/climbs/${id}`);
          return response.data;
        },
        enabled: !!id
    });

    const updateClimbs = useMutation({
        mutationFn: async (climb: Climb) => {
            await agent.put('/climbs', climb)
        },
        onSuccess: async () => {
            await queryClient.invalidateQueries({
                queryKey: ['climbs']
            })
        }
    })

    const createClimb = useMutation({
        mutationFn: async (climb:Climb) => {
            const response = await agent.post('/climbs', climb);
            return response.data;
        },
        onSuccess: async () => {
            await queryClient.invalidateQueries({
                queryKey: ['climbs']
            })
        }
    })

    const deleteClimb = useMutation({
        mutationFn: async (id:string) => {
            await agent.delete(`/climbs/${id}`)
        },
        onSuccess: async () => {
            await queryClient.invalidateQueries({
                queryKey: ['climbs']
            })
        }
    })

    return {
        climbs,
        climb,
        isLoadingClimb,
        isPending,
        updateClimbs,
        createClimb,
        deleteClimb
    }
}