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

const replyFormDict = {};
const postWrappers = document.getElementsByClassName("post-wrapper");
for (let i = 0; i < postWrappers.length; i++)
{
	const replyForm = postWrappers[i].getElementsByClassName("reply-form")[0];
	let postId = postWrappers[i].getElementsByClassName("post-id")[0].innerHTML;
	replyFormDict[postId] = replyForm;
}

function hideAllForms(formsDict)
{
	for (let formId in formsDict)
	{
		if (formsDict.hasOwnProperty((formId)))
			formsDict[formId].style.display = "none";
	}
}

hideAllForms(replyFormDict);

function showReplyForm(postId)
{
	hideAllForms(replyFormDict);
	replyFormDict[postId].style.display = "block";
}

