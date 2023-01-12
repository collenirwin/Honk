using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// This application's <see cref="IdentityUser"/> class.
/// </summary>
public class ApplicationUser : IdentityUser, ITimeTracked
{
    /// <summary>
    /// Users this user has blocked.
    /// </summary>
    [InverseProperty(nameof(Block.BlockedBy))]
    public ICollection<Block> BlockedUsers { get; set; } = null!;

    /// <summary>
    /// Users that have blocked this user.
    /// </summary>
    [InverseProperty(nameof(Block.Blocked))]
    public ICollection<Block> BlockedByUsers { get; set; } = null!;

    /// <summary>
    /// Friend requests that this user has sent.
    /// </summary>
    [InverseProperty(nameof(FriendRequestNotification.Requestor))]
    public ICollection<FriendRequestNotification> SentFriendRequests { get; set; } = null!;

    /// <summary>
    /// Friend requests that this user has received.
    /// </summary>
    [InverseProperty(nameof(FriendRequestNotification.For))]
    public ICollection<FriendRequestNotification> ReceivedFriendRequests { get; set; } = null!;

    /// <summary>
    /// Albums this user has created.
    /// </summary>
    [InverseProperty(nameof(Album.CreatedBy))]
    public ICollection<Album> Albums { get; set; } = null!;

    /// <summary>
    /// Albums this user can view.
    /// </summary>
    [InverseProperty(nameof(Album.ViewUsers))]
    public ICollection<Album> ViewableAlbums { get; set; } = null!;

    /// <summary>
    /// Albums this user can modify.
    /// </summary>
    [InverseProperty(nameof(Album.ModificationUsers))]
    public ICollection<Album> ModifiableAlbums { get; set; } = null!;

    /// <summary>
    /// Albums this user can delete.
    /// </summary>
    [InverseProperty(nameof(Album.DeletionUsers))]
    public ICollection<Album> DeletableAlbums { get; set; } = null!;

    /// <summary>
    /// Photos this user has created.
    /// </summary>
    [InverseProperty(nameof(Photo.UploadedBy))]
    public ICollection<Photo> Photos { get; set; } = null!;

    /// <summary>
    /// Photos this user can view.
    /// </summary>
    [InverseProperty(nameof(Photo.ViewUsers))]
    public ICollection<Photo> ViewablePhotos { get; set; } = null!;

    /// <summary>
    /// Photos this user can modify.
    /// </summary>
    [InverseProperty(nameof(Photo.ModificationUsers))]
    public ICollection<Photo> ModifiablePhotos { get; set; } = null!;

    /// <summary>
    /// Photos this user can delete.
    /// </summary>
    [InverseProperty(nameof(Photo.DeletionUsers))]
    public ICollection<Photo> DeletablePhotos { get; set; } = null!;

    /// <summary>
    /// Notifications for comments on albums.
    /// </summary>
    public ICollection<AlbumCommentNotification> AlbumCommentNotifications { get; set; } = null!;

    /// <summary>
    /// Notifications for comments on photos.
    /// </summary>
    public ICollection<PhotoCommentNotification> PhotoCommentNotifications { get; set; } = null!;

    /// <inheritdoc />
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc />
    public DateTime UpdatedOn { get; set; }
}
