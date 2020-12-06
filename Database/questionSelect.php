<?php
include('connection.php');

$sql = "SELECT  Questions.QuestionID, Questions.QuestionText, Questions.GoodAnswer, Questions.WrongAnswer1, Questions.WrongAnswer2, Questions.Created, Questions.Difficulty, Questions.ActiveInGame, Eras.EraName From Questions INNER JOIN Eras on Questions.EraID = Eras.EraID";
$result = mysqli_query($connect, $sql);
//
if(mysqli_num_rows($result)>0) {
    while($row = mysqli_fetch_assoc($result)) {
        echo "Vraag: ".$row['QuestionText'].";";
    }
}

?>