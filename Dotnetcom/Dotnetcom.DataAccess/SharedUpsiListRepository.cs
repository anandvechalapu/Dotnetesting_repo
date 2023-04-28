namespace Dotnetcom.Repositories
{
    public class SharedUpsiListRepository : ISharedUpsiListRepository
    {
        private readonly DotnetcomDbContext _context;

        public SharedUpsiListRepository(DotnetcomDbContext context)
        {
            _context = context;
        }

        public async Task<SharedUpsiListModel> GetByIdAsync(int id)
        {
            return await _context.SharedUpsiLists
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<SharedUpsiListModel>> GetAllAsync()
        {
            return await _context.SharedUpsiLists.ToListAsync();
        }

        public async Task<SharedUpsiListModel> AddAsync(SharedUpsiListModel model)
        {
            _context.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<SharedUpsiListModel> UpdateAsync(SharedUpsiListModel model)
        {
            _context.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _context.SharedUpsiLists
                .SingleOrDefaultAsync(x => x.Id == id);
            _context.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}