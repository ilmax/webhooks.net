﻿namespace Octokit.Webhooks.Models
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record DiscussionAnswer
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("node_id")]
        public string NodeId { get; init; }

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; init; }

        [JsonPropertyName("parent_id")]
        public int? ParentId { get; init; }

        [JsonPropertyName("child_comment_count")]
        public int ChildCommentCount { get; init; }

        [JsonPropertyName("repository_url")]
        public string RepositoryUrl { get; init; }

        [JsonPropertyName("discussion_id")]
        public int DiscussionId { get; init; }

        [JsonPropertyName("author_association")]
        public AuthorAssociation AuthorAssociation { get; init; }

        [JsonPropertyName("user")]
        public User User { get; init; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; init; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; init; }

        [JsonPropertyName("body")]
        public string Body { get; init; }
    }
}