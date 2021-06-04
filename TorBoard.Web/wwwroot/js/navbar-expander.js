let isNavbarExpanded = false;
const navbar = document.getElementsByClassName("navmenu")[0];

function ToggleNavItems()
{
	isNavbarExpanded = !isNavbarExpanded;
	navbar.style.display = isNavbarExpanded ? "flex" : null;
}
