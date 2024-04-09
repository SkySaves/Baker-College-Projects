document.addEventListener("DOMContentLoaded", function() {
    // thumbnail click event handler
    const thumbBox = document.getElementById('thumbBox');
    thumbBox.addEventListener('click', function(event) {
        if (event.target.tagName === 'IMG') {
            const mainImage = document.querySelector('#imgManipulated img');
            const newSrc = event.target.src.replace('small', 'medium');
            mainImage.src = newSrc;
            
            const figcaption = document.querySelector('#imgManipulated figcaption');
            figcaption.innerHTML = `<em>${event.target.alt}</em><br><span>${event.target.title}</span>`;
        }
    });

    // slider change event handler
    const sliders = document.querySelectorAll('.sliders');
    sliders.forEach(slider => {
        slider.addEventListener('input', function() {
            const image = document.querySelector('#imgManipulated img');
            const opacity = document.getElementById('sliderOpacity').value;
            const saturation = document.getElementById('sliderSaturation').value;
            const brightness = document.getElementById('sliderBrightness').value;
            const hue = document.getElementById('sliderHue').value;
            const gray = document.getElementById('sliderGray').value;
            const blur = document.getElementById('sliderBlur').value;

            image.style.filter = `opacity(${opacity}%) saturate(${saturation}%) brightness(${brightness}%) hue-rotate(${hue}deg) grayscale(${gray}%) blur(${blur}px)`;

            // value display
            document.getElementById('numOpacity').textContent = opacity;
            document.getElementById('numSaturation').textContent = saturation;
            document.getElementById('numBrightness').textContent = brightness;
            document.getElementById('numHue').textContent = hue;
            document.getElementById('numGray').textContent = gray;
            document.getElementById('numBlur').textContent = blur;
        });
    });


    document.getElementById('resetFilters').addEventListener('click', function(event) {
        event.preventDefault();
        const image = document.querySelector('#imgManipulated img');
        image.style.filter = 'none';

        // reset sliders and values
        document.getElementById('sliderOpacity').value = 100;
        document.getElementById('sliderSaturation').value = 100;
        document.getElementById('sliderBrightness').value = 100;
        document.getElementById('sliderHue').value = 0;
        document.getElementById('sliderGray').value = 0;
        document.getElementById('sliderBlur').value = 0;

        document.getElementById('numOpacity').textContent = 100;
        document.getElementById('numSaturation').textContent = 100;
        document.getElementById('numBrightness').textContent = 100;
        document.getElementById('numHue').textContent = 0;
        document.getElementById('numGray').textContent = 0;
        document.getElementById('numBlur').textContent = 0;
    });
});
