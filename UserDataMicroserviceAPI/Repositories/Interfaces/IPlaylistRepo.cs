using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IPlaylistRepo
    {


        Task<ActionResult<Playlist>> GetPlaylist(string playlistId);

        Task<ActionResult<IQueryable<Playlist>>> GetUserPlaylists(string userId);

        Task<ActionResult<List<Course>>> GetPlaylistCourses(string playlistId);

        Task<ActionResult<Playlist>> PostPlaylist(Playlist inspiration);

        Task<ActionResult<Playlist>> UpdatePlaylist(Playlist playlist);

        void DeletePlaylist(Playlist playlist);
    }
}
