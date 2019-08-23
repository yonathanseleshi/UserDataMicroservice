using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class PlaylistRepo : IPlaylistRepo
    {
        public PlaylistRepo()
        {
        }

        public void DeletePlaylist(Playlist playlist)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Playlist>> GetPlaylist(string playlistId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<Course>>> GetPlaylistCourses(string playlistId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Playlist>>> GetUserPlaylists(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Playlist>> PostPlaylist(Playlist inspiration)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Playlist>> UpdatePlaylist(Playlist playlist)
        {
            throw new NotImplementedException();
        }
    }
}
