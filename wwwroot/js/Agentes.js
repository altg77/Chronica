document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('.dropdown-item.Sair').forEach(button => {
        button.addEventListener('click', (event) => {
            event.preventDefault();

            const card = button.closest('.card');
            const agentName = card ? card.querySelector('h2').textContent : 'este agente';

            if (confirm(`Tem certeza que deseja sair de "${agentName}"? Isso o deletará.`)) {
                alert(`Você saiu de "${agentName}". (Ação de exclusão simulada)`);
            }
        });
    });
});

document.addEventListener('DOMContentLoaded', () => {
    const attributes = {
        agi: 1,
        int: 1,
        vig: 1,
        pre: 1,
        for: 1
    };

    let availablePoints = 5;
    const maxAttributeValue = 3;
    const minAttributeValue = 0;

    const availablePointsSpan = document.getElementById('available-points');

    const updateAttributeDisplay = () => {
        for (const attr in attributes) {
            document.getElementById(`val-${attr}`).textContent = attributes[attr];
        }
        availablePointsSpan.textContent = availablePoints;

        // Enable/disable buttons based on points and limits
        for (const attr in attributes) {
            const increaseBtn = document.querySelector(`.btn-increase[data-attr="${attr}"]`);
            const decreaseBtn = document.querySelector(`.btn-decrease[data-attr="${attr}"]`);

            // Disable increase if no points left or at max value
            if (availablePoints === 0 || attributes[attr] >= maxAttributeValue) {
                increaseBtn.disabled = true;
            } else {
                increaseBtn.disabled = false;
            }

            // Disable decrease if at min value (0)
            if (attributes[attr] <= minAttributeValue) {
                decreaseBtn.disabled = true;
            } else {
                decreaseBtn.disabled = false;
            }
        }
    };

    document.querySelectorAll('.btn-increase').forEach(button => {
        button.addEventListener('click', (event) => {
            const attr = event.target.dataset.attr;
            if (availablePoints > 0 && attributes[attr] < maxAttributeValue) {
                attributes[attr]++;
                availablePoints--;
                updateAttributeDisplay();
            }
        });
    });

    document.querySelectorAll('.btn-decrease').forEach(button => {
        button.addEventListener('click', (event) => {
            const attr = event.target.dataset.attr;
            if (attributes[attr] > minAttributeValue) {
                attributes[attr]--;
                availablePoints++; // Always gain a point when decreasing
                updateAttributeDisplay();
            }
        });
    });

    // Initial display update
    updateAttributeDisplay();

    // --- Tab Switching Logic ---
    const navTabs = document.querySelectorAll('.navHeranc a');
    const contentSections = document.querySelectorAll('.content-section');

    navTabs.forEach(tab => {
        tab.addEventListener('click', (event) => {
            event.preventDefault(); // Prevent default link behavior

            // Remove 'active' class from current active tab
            document.querySelector('.navHeranc a.active').classList.remove('active');
            event.target.classList.add('active');

            // Hide all content sections
            contentSections.forEach(section => {
                section.classList.remove('active');
            });

            // Show the corresponding content section
            const targetSectionId = event.target.id.replace('tab-', '') + '-section';
            document.getElementById(targetSectionId).classList.add('active');
        });
    });
});

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

document.addEventListener('DOMContentLoaded', () => {
    const filterOptions = document.querySelectorAll('.filter-option');
    const itemCards = document.querySelectorAll('.Universe-card');

    let currentFilter = 'Todos';

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