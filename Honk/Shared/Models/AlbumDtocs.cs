﻿namespace Honk.Shared.Models;

/// <summary>
/// Contains all information required for creating / editing an album.
/// </summary>
/// <param name="Name">Name of the album.</param>
/// <param name="Description">Description of the album.</param>
public record AlbumDto(string Name, string? Description);
