# Editare_Audio_Video
Tasks:
  1. Button load / play video + how many buttons (or different ways of implementing right click / menu / tab etc..)
  2. Select ROI (an the first frame of the video). If no ROI is selected the operations are going to be applied on the entire video
  3. Convert ROI to grayscale
  4. Extract only a specific color from ROI (see only R or G or B component)
  5. Make video ROI in "carousel" mode: first frame convert to gray scale, second frame see only R component, third frame  see only G component, fourth frame see only B component, fifth frame again grayscale, etc
  6. Apply brightness correction / gamma corrections ROI
  7. Apply background subtraction to ROI and replace it with a specified picture
  8. Adjust color space/map on ROI
  9. Resize/Rotate on ROI
  10. Button to select 2 videos and unite them with the following transitions
  11. Cross-dissolve (addWeigthed last 10 frames from previous video with first 10 from next Video)
  12. Video combining - play first video and on top of it (in a smaller window) play the second video (video in video)
  13. Button to select 3 audio files and 1 video.
  14. Mix the first 2 audio files into 1 (they should have same length) (first one should have 0.45 input, second one should be 0.35)
  15. The output concatenate with the third audio selected. The  Concatenate the 2 audio files with implementing cross fading (fade out first audio when it finishes / fade in second audio when it starts)
  16. Change the pitch level of the generated audio with one octave up OR  one octave down
  17. The generated audio file should be added as sound to the video  
