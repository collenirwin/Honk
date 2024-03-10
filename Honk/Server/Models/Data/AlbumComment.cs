﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a comment on an album.
/// </summary>
[Table("album_comments")]
public class AlbumComment : BaseComment
{
    /// <summary>
    /// <see cref="Album.Id"/> of the album this comment is on.
    /// </summary>
    [ForeignKey(nameof(Album))]
    [Column("album_id")]
    public Guid AlbumId { get; set; }

    /// <summary>
    /// The album this comment is on.
    /// </summary>
    public Album? Album { get; set; }
}
