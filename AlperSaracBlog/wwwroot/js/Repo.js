const username = 'alpersarac'; // Replace 'alpersarac' with your GitHub username

const repositoriesContainer = document.getElementById('repositories-container');
const allRepositoriesLink = document.getElementById('all-repositories-link');

fetch(`https://api.github.com/users/${username}/repos`)
    .then(response => response.json())
    .then(repositories => {
        repositories.forEach(repo => {
            const repositoryItem = document.createElement('div');
            repositoryItem.className = 'repository-item';

            const link = document.createElement('a');
            link.href = repo.html_url;
            link.textContent = repo.name;
            link.target = '_blank'; // Opens the link in a new tab

            repositoryItem.appendChild(link);
            repositoriesContainer.appendChild(repositoryItem);
        });

        allRepositoriesLink.href = `https://github.com/${username}?tab=repositories`;
    })
    .catch(error => {
        console.error('Error fetching repositories:', error);
    });
