// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const posts = document.getElementsByClassName("post");
for (let i = 0; i < posts.length; i++)
{
	let post = posts[i];
	post.innerHTML = post.innerHTML.replaceAll(/(&gt;.+)/g, "<span class=\"greentext\">$1</span>");
}

