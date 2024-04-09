const photos = JSON.parse(content);

 
 const parentSection = document.getElementById('parent');
 
 photos.forEach(photo => {

     const figure = document.createElement('figure');
 
     
     const img = document.createElement('img');
     img.src = `images/${photo.filename}`;
     img.alt = photo.title;
 
     figure.appendChild(img);
 
     const figcaption = document.createElement('figcaption');

     const h2 = document.createElement('h2');
     h2.textContent = photo.title;
     figcaption.appendChild(h2);

     const p = document.createElement('p');
     p.textContent = photo.description;
     figcaption.appendChild(p);
 

     photo.colors.forEach(color => {
         const span = document.createElement('span');
         span.style.backgroundColor = color.hex;
         span.textContent = color.name;
         figcaption.appendChild(span);
     });
 

     figure.appendChild(figcaption);
 
     parentSection.appendChild(figure);
 });
 