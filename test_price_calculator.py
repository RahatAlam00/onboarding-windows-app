import pytest

from price_calculator import calculate_price_per_item


def test_calculates_price_per_item_correctly():
    result = calculate_price_per_item(100, 5)

    assert result == 20


def test_rejects_negative_total_price():
    with pytest.raises(ValueError, match="Total price cannot be negative."):
        calculate_price_per_item(-100, 5)


def test_rejects_zero_item_count():
    with pytest.raises(ValueError, match="Item count must be greater than zero."):
        calculate_price_per_item(100, 0)


def test_rejects_negative_item_count():
    with pytest.raises(ValueError, match="Item count must be greater than zero."):
        calculate_price_per_item(100, -5)
