document.addEventListener('DOMContentLoaded', () => {
    const filterOptions = document.querySelectorAll('.filter-option');
    const itemCards = document.querySelectorAll('.Universe-card');

    let currentFilter = 'Todos';

    document.querySelectorAll("details").forEach((detail) => {
        detail.addEventListener("toggle", () => {
            const arrow = detail.querySelector(".seta");
            if (detail.open) {
                arrow.classList.add("rotated");
            } else {
                arrow.classList.remove("rotated");
            }
        });
    });

    function filterItems() {
        itemCards.forEach(item => {
            const itemType = item.dataset.type; // Get type from data-type attribute

            const matchesFilter = currentFilter === 'Todos' || itemType === currentFilter;

            if (matchesFilter) {
                item.classList.remove('hidden'); // Show the item
            } else {
                item.classList.add('hidden'); // Hide the item
            }
        });
    }

    // Event listeners for filter options
    filterOptions.forEach(option => {
        option.addEventListener('click', () => {
            filterOptions.forEach(opt => opt.classList.remove('active'));
            option.classList.add('active');
            currentFilter = option.dataset.filter;
            filterItems(); // Call the filtering function
        });
    });

    // Initial call to filter items when the page loads
    filterItems();
});