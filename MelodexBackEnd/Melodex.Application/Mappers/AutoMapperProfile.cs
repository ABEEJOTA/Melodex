using AutoMapper;
using Melodex.Application.DTOs;
using Melodex.Domain;
using Melodex.Domain.Models; // Asegúrate de usar el namespace correcto

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Artist, ArtistDTO>(); // De Modelo a DTO 
        CreateMap<ArtistDTO, Artist>(); // De DTO a Modelo (opcional)

        CreateMap<Cassette, CassetteDTO>(); // De Modelo a DTO 
        CreateMap<CassetteDTO, Cassette>(); // De DTO a Modelo (opcional)

        CreateMap<CD, CDDTO>(); // De Modelo a DTO 
        CreateMap<CDDTO, CD>(); // De DTO a Modelo (opcional)

        CreateMap<Collection, CollectionDTO>(); // De Modelo a DTO 
        CreateMap<CollectionDTO, Collection>(); // De DTO a Modelo (opcional)

        CreateMap<MediaItem, MediaItemDTO>(); // De Modelo a DTO 
        CreateMap<MediaItemDTO, MediaItem>(); // De DTO a Modelo (opcional)

        CreateMap<PlayList, PlayListDTO>(); // De Modelo a DTO 
        CreateMap<PlayListDTO, PlayList>(); // De DTO a Modelo (opcional)

        CreateMap<Track, TrackDTO>(); // De Modelo a DTO 
        CreateMap<TrackDTO, Track>(); // De DTO a Modelo (opcional)

        CreateMap<User, UserDTO>(); // De Modelo a DTO 
        CreateMap<UserDTO, User>(); // De DTO a Modelo (opcional)

        CreateMap<Vinyl, VinylDTO>(); // De Modelo a DTO 
        CreateMap<VinylDTO, Vinyl>(); // De DTO a Modelo (opcional)
    }
}