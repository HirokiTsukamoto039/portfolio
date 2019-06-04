<?php
namespace App\Controller;

use App\Controller\AppController;

/**
 * Dropofrunrankingaverage Controller
 *
 * @property \App\Model\Table\DropofrunrankingaverageTable $Dropofrunrankingaverage
 *
 * @method \App\Model\Entity\Dropofrunrankingaverage[]|\Cake\Datasource\ResultSetInterface paginate($object = null, array $settings = [])
 */
class DropofrunrankingaverageController extends AppController
{
    public function getRanking()
    {
        $this->autoRender = false;

        $postDataFloor = $_POST["Floor"];

        $query = $this->Dropofrunrankingaverage->find("all");

        if($postDataFloor)
        {
            $query->where(['Floor'=>$postDataFloor]);
        }
        $query->order(['AverageTime'=>'DESC']);
        $query->order(['Floor'=>'ASC']);
        $query->order(['Time'=>'DESC']);
        $query->limit(10);

        $json = json_encode($query);

        echo $json;

    }

    public function setRanking()
    {
        $this->autoRender = false;

        $postName = $this->request->data["Name"];
        $postFloor = $this->request->data["Floor"];
        $postTime = $this->request->data["Time"];
        $postAverageTime = $this->request->data["AverageTime"];

        $recode = array(
            "Name"=>$postName,
            "Floor"=>$postFloor,
            "Time"=>$postTime,
            "AverageTime"=>$postAverageTime
        );

        $prm1 = $this->Dropofrunrankingaverage->newEntity();
        $prm2 = $this->Dropofrunrankingaverage->patchEntity($prm1,$recode);
        if($this->Dropofrunrankingaverage->save($prm2))
        {
            echo "1";
        }else
        {
            echo "0";
        }
    }
}
