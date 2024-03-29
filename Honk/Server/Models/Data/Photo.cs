﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents an uploaded photo in an album.
/// </summary>
[Index(nameof(Path), nameof(AlbumId), IsUnique = true)]
public class Photo : BasePrivacyRestrictable
{
    /// <summary>
    /// File path to the photo.
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// Optional description of the photo.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// <see cref="Album.Id"/> of the album this photo is in.
    /// </summary>
    [ForeignKey(nameof(Album))]
    public Guid AlbumId { get; set; }

    /// <summary>
    /// The album this photo is in.
    /// </summary>
    public Album? Album { get; set; }

    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who uploaded this photo.
    /// </summary>
    [ForeignKey(nameof(UploadedBy))]
    public string UploadedByUserId { get; set; } = null!;

    /// <summary>
    /// The user who uploaded this photo.
    /// </summary>
    public ApplicationUser? UploadedBy { get; set; }

    /// <summary>
    /// Tags on this photo.
    /// </summary>
    public ICollection<Tag> Tags { get; set; } = null!;

    /// <summary>
    /// Comments on this photo.
    /// </summary>
    public ICollection<PhotoComment> Comments { get; set; } = null!;
}
