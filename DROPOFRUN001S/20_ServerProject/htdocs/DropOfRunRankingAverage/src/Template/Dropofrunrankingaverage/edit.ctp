<?php
/**
 * @var \App\View\AppView $this
 * @var \App\Model\Entity\Dropofrunrankingaverage $dropofrunrankingaverage
 */
?>
<nav class="large-3 medium-4 columns" id="actions-sidebar">
    <ul class="side-nav">
        <li class="heading"><?= __('Actions') ?></li>
        <li><?= $this->Form->postLink(
                __('Delete'),
                ['action' => 'delete', $dropofrunrankingaverage->Id],
                ['confirm' => __('Are you sure you want to delete # {0}?', $dropofrunrankingaverage->Id)]
            )
        ?></li>
        <li><?= $this->Html->link(__('List Dropofrunrankingaverage'), ['action' => 'index']) ?></li>
    </ul>
</nav>
<div class="dropofrunrankingaverage form large-9 medium-8 columns content">
    <?= $this->Form->create($dropofrunrankingaverage) ?>
    <fieldset>
        <legend><?= __('Edit Dropofrunrankingaverage') ?></legend>
        <?php
            echo $this->Form->control('Name');
            echo $this->Form->control('Floor');
            echo $this->Form->control('Time');
            echo $this->Form->control('AverageTime');
        ?>
    </fieldset>
    <?= $this->Form->button(__('Submit')) ?>
    <?= $this->Form->end() ?>
</div>
