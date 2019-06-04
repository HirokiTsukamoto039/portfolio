<?php
/**
 * @var \App\View\AppView $this
 * @var \App\Model\Entity\Dropofrunrankingaverage $dropofrunrankingaverage
 */
?>
<nav class="large-3 medium-4 columns" id="actions-sidebar">
    <ul class="side-nav">
        <li class="heading"><?= __('Actions') ?></li>
        <li><?= $this->Html->link(__('Edit Dropofrunrankingaverage'), ['action' => 'edit', $dropofrunrankingaverage->Id]) ?> </li>
        <li><?= $this->Form->postLink(__('Delete Dropofrunrankingaverage'), ['action' => 'delete', $dropofrunrankingaverage->Id], ['confirm' => __('Are you sure you want to delete # {0}?', $dropofrunrankingaverage->Id)]) ?> </li>
        <li><?= $this->Html->link(__('List Dropofrunrankingaverage'), ['action' => 'index']) ?> </li>
        <li><?= $this->Html->link(__('New Dropofrunrankingaverage'), ['action' => 'add']) ?> </li>
    </ul>
</nav>
<div class="dropofrunrankingaverage view large-9 medium-8 columns content">
    <h3><?= h($dropofrunrankingaverage->Id) ?></h3>
    <table class="vertical-table">
        <tr>
            <th scope="row"><?= __('Name') ?></th>
            <td><?= h($dropofrunrankingaverage->Name) ?></td>
        </tr>
        <tr>
            <th scope="row"><?= __('Id') ?></th>
            <td><?= $this->Number->format($dropofrunrankingaverage->Id) ?></td>
        </tr>
        <tr>
            <th scope="row"><?= __('Floor') ?></th>
            <td><?= $this->Number->format($dropofrunrankingaverage->Floor) ?></td>
        </tr>
        <tr>
            <th scope="row"><?= __('Time') ?></th>
            <td><?= $this->Number->format($dropofrunrankingaverage->Time) ?></td>
        </tr>
        <tr>
            <th scope="row"><?= __('AverageTime') ?></th>
            <td><?= $this->Number->format($dropofrunrankingaverage->AverageTime) ?></td>
        </tr>
    </table>
</div>
