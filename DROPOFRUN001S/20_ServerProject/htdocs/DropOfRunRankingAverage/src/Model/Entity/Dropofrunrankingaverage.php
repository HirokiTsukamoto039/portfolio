<?php
namespace App\Model\Entity;

use Cake\ORM\Entity;

/**
 * Dropofrunrankingaverage Entity
 *
 * @property int $Id
 * @property string $Name
 * @property int|null $Floor
 * @property int|null $Time
 * @property float|null $AverageTime
 */
class Dropofrunrankingaverage extends Entity
{
    /**
     * Fields that can be mass assigned using newEntity() or patchEntity().
     *
     * Note that when '*' is set to true, this allows all unspecified fields to
     * be mass assigned. For security purposes, it is advised to set '*' to false
     * (or remove it), and explicitly make individual fields accessible as needed.
     *
     * @var array
     */
    protected $_accessible = [
        'Name' => true,
        'Floor' => true,
        'Time' => true,
        'AverageTime' => true
    ];
}
