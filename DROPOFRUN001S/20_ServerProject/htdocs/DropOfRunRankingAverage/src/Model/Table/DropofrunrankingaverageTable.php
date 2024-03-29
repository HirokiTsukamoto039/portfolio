<?php
namespace App\Model\Table;

use Cake\ORM\Query;
use Cake\ORM\RulesChecker;
use Cake\ORM\Table;
use Cake\Validation\Validator;

/**
 * Dropofrunrankingaverage Model
 *
 * @method \App\Model\Entity\Dropofrunrankingaverage get($primaryKey, $options = [])
 * @method \App\Model\Entity\Dropofrunrankingaverage newEntity($data = null, array $options = [])
 * @method \App\Model\Entity\Dropofrunrankingaverage[] newEntities(array $data, array $options = [])
 * @method \App\Model\Entity\Dropofrunrankingaverage|bool save(\Cake\Datasource\EntityInterface $entity, $options = [])
 * @method \App\Model\Entity\Dropofrunrankingaverage saveOrFail(\Cake\Datasource\EntityInterface $entity, $options = [])
 * @method \App\Model\Entity\Dropofrunrankingaverage patchEntity(\Cake\Datasource\EntityInterface $entity, array $data, array $options = [])
 * @method \App\Model\Entity\Dropofrunrankingaverage[] patchEntities($entities, array $data, array $options = [])
 * @method \App\Model\Entity\Dropofrunrankingaverage findOrCreate($search, callable $callback = null, $options = [])
 */
class DropofrunrankingaverageTable extends Table
{
    /**
     * Initialize method
     *
     * @param array $config The configuration for the Table.
     * @return void
     */
    public function initialize(array $config)
    {
        parent::initialize($config);

        $this->setTable('dropofrunrankingaverage');
        $this->setDisplayField('Id');
        $this->setPrimaryKey('Id');
    }

    /**
     * Default validation rules.
     *
     * @param \Cake\Validation\Validator $validator Validator instance.
     * @return \Cake\Validation\Validator
     */
    public function validationDefault(Validator $validator)
    {
        $validator
            ->integer('Id')
            ->allowEmptyString('Id', 'create');

        $validator
            ->scalar('Name')
            ->maxLength('Name', 30)
            ->allowEmptyString('Name', false);

        $validator
            ->integer('Floor')
            ->allowEmptyString('Floor');

        $validator
            ->integer('Time')
            ->allowEmptyString('Time');

        $validator
            ->numeric('AverageTime')
            ->allowEmptyString('AverageTime');

        return $validator;
    }
}
