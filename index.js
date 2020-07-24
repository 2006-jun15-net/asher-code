'use strict';

const loadButton = document.getElementById("load-button");
const videoInfoDiv = document.getElementById("video-info");
const videoTitleDiv = document.getElementById("video-title");
const videoDateDiv = document.getElementById("video-date");
const videoCompetitionDiv = document.getElementById("video-competition");
const videoEmbed = document.getElementById("embed-video");
const videoList = document.getElementById("videos");
const errorMessageDiv = document.getElementById("error-message");

errorMessageDiv.style.display = "none";


fetch("https://www.scorebat.com/video-api/v1/",
  {
    method: "GET",
    headers: { "Accept": "application/json" }
  })
  .then(response => response.json())
  .then(videoData => {
    for(let i = 0; i < 5; i++)
    {
      let newItem = document.createElement('option');
      newItem.value = i;
      newItem.innerHTML = videoData[i].title;
      videoList.appendChild(newItem);
    }
  })
  .catch(error => {
    console.log(error);
    errorMessageDiv.style.display = "block";
    errorMessageDiv.innerHTML = error.toString();
  });

loadButton.addEventListener("click", () => {

  // the response has a json method which returns a promise of the repsonse body deserialized.
  fetch("https://www.scorebat.com/video-api/v1/",
    {
      method: "GET",
      headers: { "Accept": "application/json" }
    })
    .then(response => response.json())
    .then(videoData => {
      videoTitleDiv.innerHTML = videoData[videoList.options[videoList.selectedIndex].value].title;
      videoDateDiv.innerHTML = videoData[videoList.options[videoList.selectedIndex].value].date;
      videoCompetitionDiv.innerHTML = videoData[videoList.options[videoList.selectedIndex].value].competition.name;
      videoEmbed.innerHTML = videoData[videoList.options[videoList.selectedIndex].value].videos[0].embed;
      console.log("this runs second");
    })
    .catch(error => {
      console.log(error);
      errorMessageDiv.style.display = "block";
      errorMessageDiv.innerHTML = error.toString();
    });

    console.log("this runs first");
});