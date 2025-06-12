document.addEventListener('DOMContentLoaded', () => {
    const filterOptions = document.querySelectorAll('.filter-option');
    const itemCards = document.querySelectorAll('.item-card');

    let currentFilter = 'Todos';

    // Function to toggle item details (keep this as you had it)
    window.toggleDetalhes = (element) => {
        const itemDetalhes = element.nextElementSibling;
        const seta = element.querySelector('.seta');
        if (itemDetalhes.style.display === 'none') {
            itemDetalhes.style.display = 'block';
            seta.innerHTML = '&#9650;'; // Up arrow
        } else {
            itemDetalhes.style.display = 'none';
            seta.innerHTML = '&#9660;'; // Down arrow
        }
    };

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