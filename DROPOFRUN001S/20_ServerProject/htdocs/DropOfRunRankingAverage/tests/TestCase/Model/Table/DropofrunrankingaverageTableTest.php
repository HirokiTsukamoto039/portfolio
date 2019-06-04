<?php
namespace App\Test\TestCase\Model\Table;

use App\Model\Table\DropofrunrankingaverageTable;
use Cake\ORM\TableRegistry;
use Cake\TestSuite\TestCase;

/**
 * App\Model\Table\DropofrunrankingaverageTable Test Case
 */
class DropofrunrankingaverageTableTest extends TestCase
{
    /**
     * Test subject
     *
     * @var \App\Model\Table\DropofrunrankingaverageTable
     */
    public $Dropofrunrankingaverage;

    /**
     * Fixtures
     *
     * @var array
     */
    public $fixtures = [
        'app.Dropofrunrankingaverage'
    ];

    /**
     * setUp method
     *
     * @return void
     */
    public function setUp()
    {
        parent::setUp();
        $config = TableRegistry::getTableLocator()->exists('Dropofrunrankingaverage') ? [] : ['className' => DropofrunrankingaverageTable::class];
        $this->Dropofrunrankingaverage = TableRegistry::getTableLocator()->get('Dropofrunrankingaverage', $config);
    }

    /**
     * tearDown method
     *
     * @return void
     */
    public function tearDown()
    {
        unset($this->Dropofrunrankingaverage);

        parent::tearDown();
    }

    /**
     * Test initialize method
     *
     * @return void
     */
    public function testInitialize()
    {
        $this->markTestIncomplete('Not implemented yet.');
    }

    /**
     * Test validationDefault method
     *
     * @return void
     */
    public function testValidationDefault()
    {
        $this->markTestIncomplete('Not implemented yet.');
    }
}
