const toggleBtn = document.querySelector('.navbar_toogleBtn');
const menu = document.querySelector('.navbar_menu');
const icons = document.querySelector('.navbar_icons');

toggleBtn.addEventListener('click', () => {
    menu.classList.toggle('active');
    icons.classList.toggle('active');
});

// 0. Application Origin  
//console.log(location.origin);


// 1. API test 
const Url = 'https://jsonplaceholder.typicode.com/posts';

fetch(Url)
.then(response => response.json())
.then(json => console.log(json))



const Url_cityApi = 'https://localhost:7169/api/cities';

fetch(Url_cityApi)
.then(response => response.json())
//.then(data => console.log(data))
.then(data => {
  const tableBody = document.querySelector('#data-table tbody');
  data.forEach(city => {
    const row = document.createElement('tr');
    const nameCell = document.createElement('td');
    const descCell = document.createElement('td');
    nameCell.textContent = city.name;
    descCell.textContent = city.description;
    row.appendChild(nameCell);
    row.appendChild(descCell);
    tableBody.appendChild(row);
  });
})
