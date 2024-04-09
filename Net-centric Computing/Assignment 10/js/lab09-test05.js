document.addEventListener("DOMContentLoaded", function() {
    const highlightables = document.querySelectorAll('.hilightable');
    highlightables.forEach(element => {
        element.addEventListener('focus', function() {
            this.classList.add('highlight');
        });
        element.addEventListener('blur', function() {
            this.classList.remove('highlight');
        });
    });

    const form = document.getElementById('mainForm');
    form.addEventListener('submit', function(event) {
        let isFormValid = true;
        const requiredFields = document.querySelectorAll('.required');
        

        requiredFields.forEach(field => {
            if (!field.value.trim()) {
                field.classList.add('error');
                isFormValid = false;
            } else {
                field.classList.remove('error');
            }
        });
      
        if (!isFormValid) {
            event.preventDefault();
            alert('Please fill in all required fields.');
        }
    });

    requiredFields.forEach(field => {
        field.addEventListener('input', function() {
            if (this.value.trim()) {
                this.classList.remove('error');
            }
        });
    });
});
