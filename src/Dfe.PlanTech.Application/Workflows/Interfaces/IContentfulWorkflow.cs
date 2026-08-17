using Dfe.PlanTech.Core.Contentful.Models;

namespace Dfe.PlanTech.Application.Workflows.Interfaces;

public interface IContentfulWorkflow
{
    Task<IEnumerable<QuestionnaireSectionEntry>> GetAllSectionsAsync();
    Task<IEnumerable<QuestionnaireCategoryEntry>> GetAllCategoriesAsync();

    Task<QuestionnaireCategoryEntry?> GetCategoryBySlugAsync(string slug, int? includeLevel = null);

    Task<string?> GetCategoryHeaderTextBySlugAsync(string slug);

    Task<List<TEntry>> GetEntriesAsync<TEntry>()
        where TEntry : ContentfulEntry;

    Task<TEntry> GetEntryByIdAsync<TEntry>(string entryId)
        where TEntry : ContentfulEntry;

    Task<PageEntry> GetPageBySlugAsync(string slug);

    Task<IEnumerable<RecommendationChunkEntry>> GetPaginatedRecommendationEntriesAsync(int page);

    Task<int> GetRecommendationChunkCountAsync(int page);

    Task<string?> GetRedirectedSlugFromRequestedSlugAsync(string slug);

    Task<QuestionnaireSectionEntry> GetSectionBySlugAsync(
        string sectionSlug,
        int? includeLevel = null
    );
}
