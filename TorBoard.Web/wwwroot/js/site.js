// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const posts = document.getElementsByClassName("post");
for (let i = 0; i < posts.length; i++)
{
	let post = posts[i];
	post.innerHTML = post.innerHTML.replaceAll(/(&gt;.+)/g, "<span class=\"greentext\">$1</span>");
	post.innerHTML = post.innerHTML.replaceAll(/\[spoiler](.+)\[\/spoiler]/g, "<span class=\"spoiler\">$1</span>");
	post.innerHTML = post.innerHTML.replaceAll(/\*\*(.+)\*\*/g, "<b>$1</b>");
	post.innerHTML = post.innerHTML.replaceAll(/\*(.+)\*/g, "<i>$1</i>");
	post.innerHTML = post.innerHTML.replaceAll(/\*(.+)/g, "<span class=\"list-item\">$1</span>");
}

