document.addEventListener('DOMContentLoaded', () => {
    const filterOptions = document.querySelectorAll('.filter-option');
    const monsterItems = document.querySelectorAll('.monster-item'); // Get all monster items
    const noMonsterFoundMessage = document.getElementById('no-monster-found');

    let currentFilter = 'Todos';
    let currentSearchTerm = '';

    function filterAndSearchMonsters() {
        let foundMonstersCount = 0;

        monsterItems.forEach(item => {
            const monsterType = item.dataset.type; // Get type from data-type attribute
            const monsterName = item.dataset.name.toLowerCase(); // Get name from data-name attribute

            const matchesFilter = currentFilter === 'Todos' || monsterType === currentFilter;
            const matchesSearch = monsterName.includes(currentSearchTerm.toLowerCase());

            if (matchesFilter && matchesSearch) {
                item.classList.remove('hidden'); // Show the item
                foundMonstersCount++;
            } else {
                item.classList.add('hidden'); // Hide the item
            }
        });

        // Show/hide the "no monster found" message
        if (foundMonstersCount === 0) {
            noMonsterFoundMessage.style.display = 'block';
        } else {
            noMonsterFoundMessage.style.display = 'none';
        }
    }

    // Event listeners for filter options
    filterOptions.forEach(option => {
        option.addEventListener('click', () => {
            filterOptions.forEach(opt => opt.classList.remove('active'));
            option.classList.add('active');
            currentFilter = option.dataset.filter;
            filterAndSearchMonsters(); // Call the unified function
        });
    });

    // Event listener for search input
    monsterSearchInput.addEventListener('input', (e) => {
        currentSearchTerm = e.target.value;
        filterAndSearchMonsters(); // Call the unified function
    });

    // Initial filter and search application (to ensure "Todos" and any initial search is applied)
    filterAndSearchMonsters();
});